using System.Diagnostics;

namespace WebApiCs.Api
{
    public static class ExecuteEndpoints
    {
        public static void MapExecuteEndpoints(this WebApplication app)
        {
            app.MapGet("/execute", () =>
            {
                // Get file names in opt directory
                var files = Directory.GetFiles("opt");
                // Execute the first file with redirected standard output
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = files[0],
                    RedirectStandardOutput = true
                };
                var process = Process.Start(processStartInfo);
                if (process == null)
                {
                    throw new InvalidOperationException("Failed to start process.");
                }
                // Get the output of the process
                var output = process.StandardOutput.ReadToEnd();
                return output;

            }).WithName("GetExecute");
        }
    }
}