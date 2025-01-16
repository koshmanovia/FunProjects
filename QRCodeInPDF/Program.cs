/*

using System;
using System.Drawing;
using System.IO;
using QRCoder;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Входные данные
        string url = "https://example.com";
        string companyName = "Примерная Фирма";
        string legalInfo = "© 2025 Примерная Фирма. Все права защищены.";
        string currentDirectory = Environment.CurrentDirectory;
        string outputFilePath = currentDirectory + @"\QRDocument.pdf";
        string iconPath = currentDirectory + @"\icon.png"; // Путь к иконке

        // Генерация QR-кода
        Bitmap qrCodeImage = GenerateQRCodeWithIcon(url, iconPath);

        // Создание PDF
        CreatePDFDocument(outputFilePath, qrCodeImage, companyName, legalInfo);

        Console.WriteLine("PDF документ успешно создан: " + outputFilePath);
    }

    static Bitmap GenerateQRCodeWithIcon(string url, string iconPath)
    {
        using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
        {
            //QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            //QRCode qrCode = new QRCode(qrCodeData);

            //Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White,
            //    (Bitmap)Image.FromFile(iconPath));

            //return qrCodeImage;
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            return qrCode.GetGraphic(20, Color.Black, Color.White,
                (Bitmap)System.Drawing.Image.FromFile(iconPath));
        }
    }

    static void CreatePDFDocument(string outputFilePath, Bitmap qrCodeImage, string companyName, string legalInfo)
    {

        using (PdfWriter writer = new PdfWriter(outputFilePath))
        {
            PdfDocument pdf = new PdfDocument(writer);

            // Используем явно iText.Layout.Document
            iText.Layout.Document document = new iText.Layout.Document(pdf);

            // Конвертация QR-кода в поток
            using (MemoryStream ms = new MemoryStream())
            {
                qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                // Добавляем QR-код в PDF
                iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(
                    ImageDataFactory.Create(ms.ToArray())
                ).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                    .SetMaxHeight(200)
                    .SetMaxWidth(200);

                document.Add(pdfImage);
            }

            document.Close();
        }
    }    
}
*/
using System;
using System.Drawing;
using System.IO;
using QRCoder;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using iText.IO.Font;
using iText.Kernel.Font;

class Program
{
    static void Main(string[] args)
    {
        string url = "https://github.com/koshmanovia/FunProjects/tree/main/QRCodeInPDF"; // URL для QR-кода
        string outputFilePath = "QRCodeWithInfo.pdf"; // Путь к результату
        string iconPath = "icon.png"; // Путь к иконке
        string companyName = "Example Company"; // Имя компании
        string legalInfo = "Все права защищены."; // Юридическая информация

        // Генерация QR-кода с иконкой
        Bitmap qrCodeImage = GenerateQRCodeWithIcon(url, iconPath);

        // Создание PDF-документа
        CreatePDFDocument(outputFilePath, qrCodeImage, companyName, legalInfo);
        Console.WriteLine("PDF документ успешно создан: " + outputFilePath);
    }

    // Генерация QR-кода с иконкой
    static Bitmap GenerateQRCodeWithIcon(string url, string iconPath)
    {
        using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
        {
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            // Загружаем иконку и помещаем её в центр QR-кода
            return qrCode.GetGraphic(20, Color.Black, Color.White,
                (Bitmap)System.Drawing.Image.FromFile(iconPath));
        }
    }

    // Создание PDF-документа
    static void CreatePDFDocument(string outputFilePath, Bitmap qrCodeImage, string companyName, string legalInfo)
    {
        using (PdfWriter writer = new PdfWriter(outputFilePath))
        {
            PdfDocument pdf = new PdfDocument(writer);
            iText.Layout.Document document = new iText.Layout.Document(pdf);
            
            // Задаем шрифт
            string fontPath = "C:\\Windows\\Fonts\\Arial.ttf"; // Путь к шрифту Arial
            PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

            // Шапка документа
            document.Add(new Paragraph($"Онлайн запись в {companyName}")
                            .SetFont(font)
                            .SetFontSize(30)
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SetBold());

            // Генерация QR-кода в поток
            using (MemoryStream ms = new MemoryStream())
            {
                qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                // Добавляем QR-код в PDF
                iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(
                    ImageDataFactory.Create(ms.ToArray())
                ).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                 .SetMaxHeight(550)
                 .SetMaxWidth(550);

                document.Add(pdfImage);
            }

            // Текст под QR кодом
            document.Add(new Paragraph("Наведите камеру телефона, чтобы записаться на сервис.")
                            .SetFont(font)
                            .SetFontSize(12)
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

            // Юридическая информация внизу страницы
            document.Add(new Paragraph(legalInfo)
                            .SetFont(font)
                            .SetFontSize(10)
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SetMarginTop(20));
            document.Close();
        }
    }
}