using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

public class HomePageTest
{
    public void TakeScreenshot()
    {
        // Iniciar el driver de Chrome
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://localhost:5025");

        // Tomar la captura de pantalla
        Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

        // Crear el directorio para guardar la imagen si no existe
        string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // Guardar la imagen con la ruta correcta en formato PNG
        string screenshotPath = Path.Combine(directoryPath, "HomePageTest.png");
        //screenshot.SaveAsFile(screenshotPath, System.Drawing.Imaging.ImageFormat.Png); // Usar ImageFormat.Png directamente

        // Cerrar el navegador
        driver.Quit();
    }
}
