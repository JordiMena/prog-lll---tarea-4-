using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Xunit;

public class TestReport
{
    private ExtentReports extent;
    private ExtentTest? test;

    public TestReport()
    {
        // Configurar el Spark Reporter (en lugar del obsoleto ExtentHtmlReporter)
        var sparkReporter = new ExtentSparkReporter("TestReport.html");
        extent = new ExtentReports();
        extent.AttachReporter(sparkReporter);
    }

    [Fact]
    public void SampleTest()
    {
        test = extent.CreateTest("SampleTest").Info("Test Started");
        try
        {
            // Código de prueba
            test.Pass("Test Passed");
        }
        catch (Exception e)
        {
            test.Fail($"Test Failed: {e.Message}");
        }
        finally
        {
            extent.Flush(); // Guarda el reporte al finalizar la ejecución
        }
    }
}
