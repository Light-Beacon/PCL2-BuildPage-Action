using CommandLine;

namespace BuildPageAction;

public class ActionInputs
{
    [Option('d', "dir",
        Required = true,
        HelpText = "工程文件所在文件夹")]
    public string Directory { get; set; } = null!;

    [Option('o', "output_path",
        Required = true,
        HelpText = "生成结果的目标路径")]
    public string OutputPath { get; set; } = null!;
}