namespace WhatsappPrank;

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

public class Prank
{
    static void Main(string[] args)
    {
        var accountSid = "ACfda1846b1a3203964d0b4d8df50d593b";
        var authToken = "a42f4d2089c82c4f273d02b58fe12446";
        TwilioClient.Init(accountSid, authToken);
        
        var sender = new PhoneNumber("whatsapp:+14155238886");
        var recipient = new PhoneNumber("whatsapp:+34604270362");
        
        var messageOptions = new CreateMessageOptions(recipient);
        messageOptions.From = sender;

        string[] messages = [
            "Hola Giselle!", 
            "Te hemos insertado un virus en tu teléfono. Tenemos todos tus datos. No intentes apagarlo.", 
            "Nombre: Giselle Campuzano González",
            "Fecha de Nacimiento: 1 de Septiembre de 1987",
            "Edad: 37 años",
            "Cónyuge: Néstor Brito Medina",
            "Hijos: 2",
            "Victoria Brito Campuzano, Colegio RR Calasancias, Sevilla, España",
            "Néstor Brito Campuzano, Eschola Snoopy SL, Sevilla, España",
            "Email: gisnes87@gmail.com",
            "Teléfono: +34604270362",
            "Dirección: Calle Manzanilla, 9, 5D, Sevilla, España",
            "Madre: Margarita Elizabeth Gonzélez Caballero",
            "Padre: Álvaro Campuzano Valdés",
            "Hermanos: Liz Laura Campuzano González",
            "Tenemos tu información de cuenta bancaria y contraseñas. Contáctanos para evitar que se publiquen tus datos.",
            
        ];
        
        foreach (var message in messages)
        {
            messageOptions.Body = message;
            MessageResource.Create(messageOptions);
            Console.WriteLine($"Sent message: {message}");
            Thread.Sleep(6000);
        }

        // for (int i = 0; i < 100; i++)
        // {
        //     messageOptions.Body = $"For loop message {i}";
        //     MessageResource.Create(messageOptions);
        //     Console.WriteLine($"Sent message: {i}");
        //     Thread.Sleep(100);
        // }

        // string? message;
        // do
        // {
        //     Console.WriteLine($"Send message to {recipient.ToString().Replace("whatsapp:", "")}:");
        //     message = Console.ReadLine();
        //
        //     if (message == "\\stop") continue;
        //     messageOptions.Body = message;
        //     MessageResource.Create(messageOptions);
        //     
        //     Console.WriteLine($"Sent: {message}");
        //     Thread.Sleep(1000);
        // } while (message != "\\stop");
        //
        // Console.WriteLine("Prank finished.");
    }
}