using JWTAuthApi.DTOs;
using JWTAuthApi.Models;
using JWTAuthApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IJwtTokenService _tokenService;
    private readonly ILogger<AuthController> _logger;

    public AuthController(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            RoleManager<IdentityRole> roleManager,
            IJwtTokenService tokenService,
            ILogger<AuthController> logger)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
        _tokenService = tokenService;
        _logger = logger;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDTO registerDto)
    {
        try
        {
            var existingUser = await _userManager.FindByEmailAsync(registerDto.Email);

            if (existingUser != null)
            {
                return Conflict(new { message = "Email is already registered" });
            }

            var newUser = new User
            {
                UserName = registerDto.Email,
                Email = registerDto.Email,
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(newUser, registerDto.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);
                return BadRequest(new
                {
                    message = "Registration failed",
                    errors
                });
            }

            await _userManager.AddToRoleAsync(newUser, "User");
            _logger.LogInformation("User {Email} registered successfully", registerDto.Email);

            return CreatedAtAction(nameof(GetProfile), new { }, new
            {
                message = "User registered successfully",
                userId = newUser.Id,
                email = newUser.Email
            });
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Error during user registration for {Email}", registerDto.Email);
            return StatusCode(500, new
            {
                message = "Registration failed due to server error"
            });
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDTO loginDto)
    {
        try
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null)
            {
                _logger.LogWarning("Login attempt with non-existent email: {Email}", loginDto.Email);
                return Unauthorized(new { message = "Invalid Credentials." });
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, lockoutOnFailure: true);

            if (!result.Succeeded)
            {
                _logger.LogWarning("Failed login attempt for user: {Email}", loginDto.Email);
                if (result.IsLockedOut)
                {
                    return Unauthorized(new { message = "Account is locked out." });
                }
                return Unauthorized(new { message = "Invalid credentials." });
            }

            var roles = await _userManager.GetRolesAsync(user);
            var token = _tokenService.GenerateToken(user, roles.ToList());

            _logger.LogInformation("User {Email} logged in successfully", user.Email);

            return Ok(new AuthResponseDTO
            {
                Token = token,
                Email = user.Email ?? "",
                FullName = user.FullName,
                Roles = roles.ToList(),
                ExpiresAt = DateTime.UtcNow.AddMinutes(60)
            });
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Error during login for {Email}", loginDto.Email);
            return StatusCode(500, new { message = "Login failed due to server error" });
        }
    }

    [HttpGet("profile")]
    [Authorize]
    public async Task<IActionResult> GetProfile()
    {
        try
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                return Unauthorized(new { message = "Invalid token" });
            }

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return NotFound(new { message = "User not found." });
            }
            var roles = await _userManager.GetRolesAsync(user);
            return Ok(new UserProfileDTO()
            {
                Id = user.Id,
                Email = user.Email ?? "",
                FirstName = user.FirstName,
                CreatedAt = user.CreatedAt,
                Roles = roles.ToList()
            });
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "Error retrieving user profile");
            return StatusCode(500, new { message = "Failed to retrieve profile" });
        }
    }

    [HttpGet("admin-only")]
    [Authorize(Roles = "Admin")]
    public IActionResult AdminOnly()
    {
        var userName = User.Identity?.Name;
        return Ok(
            new
            {
                message = "Welcome to the admin area!",
                user = userName,
                timestamp = DateTime.UtcNow
            }
        );
    }

    [HttpGet("users")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetAllUsers()
    {
        try
        {
            var users = _userManager.Users.ToList();
            var userProfiles = new List<UserProfileDTO>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                userProfiles.Add(new UserProfileDTO
                {
                    Id = user.Id,
                    Email = user.Email ?? "",
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    CreatedAt = user.CreatedAt,
                    Roles = roles.ToList()
                });
            }
            return Ok(userProfiles);
        } catch (Exception exception)
        {
            _logger.LogError(exception, "Error retrieving all users");
            return StatusCode(500, new { message = "Failed to retrieve users" });
        }
    }
}