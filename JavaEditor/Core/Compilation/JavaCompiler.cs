using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaEditor.Core.Compilation {
    public class JavaCompiler {
        public Exception Compile(string javacPath, string[] javaFiles, string commandLineOptions = "") {
            Exception ret = null;

            var startInfo = new ProcessStartInfo {
                CreateNoWindow = true,
                UseShellExecute = false,
                FileName = javacPath,
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = commandLineOptions + " " + string.Join(" ", javaFiles)
            };

            try {
                using (var javacProcess = Process.Start(startInfo)) {
                    javacProcess.WaitForExit();
                }
            } catch (Exception ex) {
                ret = ex;
            }

            return ret;
        }
    }
}
