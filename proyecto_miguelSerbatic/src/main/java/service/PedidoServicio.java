package service;

import java.util.HashMap;
import java.util.List;
import java.util.Properties;

import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;

import model.DAO.ConfiguracionDAO;
import model.DAO.DetallesPedidoDAO;
import model.DAO.PedidoDAO;
import model.VO.PedidoVO;
import model.VO.ProductoVO;

public class PedidoServicio {
	public static boolean vaciarCarrito(String email, String metodoPago) {
		if (PedidoDAO.insertarPedido(email, metodoPago)) {
			return true;
		} else {
			return false;
		}
	}

	public static boolean compra(String email, HashMap<ProductoVO, Integer> carrito, String metodoPago) {
		if (vaciarCarrito(email, metodoPago)) {
			DetallesPedidoDAO.insertarDetallesPedido(carrito);
			PedidoDAO.insertarTotalPedido();
			return true;
		} else {
			return false;
		}

	}

	public static boolean listaPedidos(int idUsuario, List<PedidoVO> pedidos) {
		pedidos = PedidoDAO.getPedidosUsuario(idUsuario);
		if (pedidos == null) {
			System.out.println("Vacio");
			return false;
		} else {
			System.out.println("Lleno");
			return true;
		}
	}

	public static void enviarPedidoCorreo(int id) {
		String destinatario = "miguelrsbernardino.ow@gmail.com";
		String asunto = "Tienda CasaDecor, su pedido: " + PedidoDAO.NumFactura(id) + " ha sido enviado";
		String mensaje = "¡Gracias por su compra!";

		Properties prop = new Properties();
		prop.setProperty("mail.smtp.host", "smtp.office365.com");
		prop.setProperty("mail.smtp.starttls.enable", "true");
		prop.setProperty("mail.smtp.port", "587");
		prop.setProperty("mail.smtp.user", "tienda-online-curso@outlook.com");
		// prop.setProperty("mail.smtp.auth", "true");
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
		} catch (MessagingException e) {
			e.printStackTrace();
		}
	}

	public static void enviarPedidosPendientesHilo() {
		Thread hilo = new Thread(new Runnable() {
			@Override
			public void run() {
				List<PedidoVO> pedidosPendientes = PedidoDAO.getPedidosPendientes();
				for (PedidoVO pedido : pedidosPendientes) {
					PedidoDAO.enviarPedido(pedido.getId());
					enviarPedidoCorreo(pedido.getId());
					ConfiguracionDAO.sumarValor();
					try {
						Thread.sleep(100);
					} catch (InterruptedException e) {
						Thread.currentThread().interrupt();
						break;
					}
				}
			}
		});
		hilo.start();
	}

	public static void enviarPedidosPendientes(int id) {
		PedidoDAO.enviarPedido(id);
		PedidoServicio.enviarPedidoCorreo(id);
		ConfiguracionDAO.sumarValor();
	}
}
