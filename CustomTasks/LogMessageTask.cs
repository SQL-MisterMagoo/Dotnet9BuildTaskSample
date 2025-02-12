using System.Diagnostics;
using System.Reflection;
using System.Text;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Task = Microsoft.Build.Utilities.Task;

namespace CustomTasks
{
  public class LogMessageTask : Task
  {
    public override bool Execute()
    {
      Log.LogMessage(MessageImportance.High, "Custom MSBuild Task executed.");
      try
      {
        var assembly = Assembly.LoadFrom("bin\\Debug\\net9.0\\SampleDotNet9App.dll");
        Log.LogMessage(MessageImportance.High, "Assembly loaded successfully.");
        var str = new StringBuilder("Assembly Attributes: ");
        str.AppendLine();
        foreach (var item in assembly.CustomAttributes)
        {
          str.AppendLine(item.ToString());
        }
        File.WriteAllText("AssemblyAttributes.txt", str.ToString());
      }
      catch (System.Exception ex)
      {

        Log.LogErrorFromException(ex);
      }
      return true;
    }
  }
}
