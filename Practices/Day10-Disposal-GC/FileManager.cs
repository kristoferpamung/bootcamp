namespace DisposalDemo;

public class FileManager : IDisposable
{
    private FileStream? _fileStream;
    private readonly string _fileName;
    private bool _disposed = false;

    public FileManager(string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
            throw new ArgumentException("File path cannot be null or empty", nameof(filePath));

        _fileName = Path.GetFileName(filePath);
        _fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        Console.WriteLine("File Manager: Opened file "+ _fileName);
    }

    public void ReadContent()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(FileManager), "Cannot read from a disposed FileManager. This object is 'dead' -no resurrection!");
        }

        if (_fileStream == null)
        {
            Console.WriteLine("No file stream available to read from");
            return;
        }

        try
        {
            _fileStream.Position = 0;
            if (_fileStream.Length > 0)
            {
                int firstByte = _fileStream.ReadByte();
                Console.WriteLine($"Read first byte from '{_fileName}' : {firstByte}");
            }
            else
            {
                Console.WriteLine($"File '{_fileName}' is empty");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file : {ex.Message}");
        }
    }
    public void Dispose()
    {
        if (_disposed)
        {
            Console.WriteLine($"🔄 Dispose() called again on '{_fileName}' - safely ignored");
            return;
        }

        if (_fileStream != null)
        {
            _fileStream.Close();
            _fileStream = null;
            Console.WriteLine($"File Manager: Released file handle for '{_fileName}'");
        }
        _disposed = true;
        GC.SuppressFinalize(this);
    }
}