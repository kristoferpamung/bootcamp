
using Oct_Solid_Principle.Interfaces;
using Oct_Solid_Principle.Logs;
using Oct_Solid_Principle.Repositories;
using Oct_Solid_Principle.Services;

ILogger logger = new ConsoleLogger();
IEmailService emailService = new EmailService(logger);
IUserRepository userRepository = new UserRepository(logger);

UserService userService = new(emailService, userRepository, logger);

userService.RegisterUser("kristofer@gmail.com", "password");
emailService.SendOrderConfirmation("kristofer", 1);