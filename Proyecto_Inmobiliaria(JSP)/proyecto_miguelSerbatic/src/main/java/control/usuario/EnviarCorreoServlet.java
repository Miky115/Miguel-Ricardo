package control.usuario;

import java.io.IOException;
import java.util.Properties;

import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;

@WebServlet("/enviarCorreo")
public class EnviarCorreoServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(EnviarCorreoServlet.class);

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String destinatario = "miguelrsbernardino.ow@gmail.com";
        String asunto = "Tienda CasaDecor, el usuario: " + request.getParameter("nombre") + " dice:";
        String mensaje = request.getParameter("mensaje");

        Properties prop = new Properties();
        prop.setProperty("mail.smtp.host", "smtp.office365.com");
        prop.setProperty("mail.smtp.starttls.enable", "true");
        prop.setProperty("mail.smtp.port", "587");
        prop.setProperty("mail.smtp.user", "tienda-online-curso@outlook.com");
        //prop.setProperty("mail.smtp.auth", "true");
        prop.setProperty("mail.smtp.ssl.protocols", "TLSv1.2");

        // Inicializamos la sesión de correo
        Session sesion = Session.getDefaultInstance(prop);

        try {
            // Creamos el mensaje
            MimeMessage email = new MimeMessage(sesion);
            email.setFrom(new InternetAddress("tienda-online-curso@outlook.com"));
            email.addRecipient(Message.RecipientType.TO, new InternetAddress(destinatario));
            email.setSubject(asunto);
            email.setText(mensaje);

            // Enviamos el mensaje
            Transport t = sesion.getTransport("smtp");
            t.connect("tienda-online-curso@outlook.com", "CursoJava2024");
            t.sendMessage(email, email.getAllRecipients());
            t.close();

            response.sendRedirect(request.getContextPath());
        } catch (MessagingException e) {
            log.error("Error al enviar el correo: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }
}
