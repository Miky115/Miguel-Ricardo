package control.pedido;

import java.io.IOException;
import java.util.HashMap;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.VO.ProductoVO;
import model.VO.UsuarioVO;
import service.PedidoServicio;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/CompraRealizada")
public class InsertarPedidoServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(InsertarPedidoServlet.class);

	public InsertarPedidoServlet() {
		super();
	}

	@SuppressWarnings("unchecked")
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);

		try {
			UsuarioVO usuario = (UsuarioVO) request.getSession().getAttribute("usuarioGuardado");
			if (usuario == null) {
				log.error("Error: El usuario no ha iniciado sesión.");
				response.sendRedirect("error.jsp");
				return;
			}

			String email = usuario.getEmail();
			String metodoPago = request.getParameter("metodo_pago");
			HashMap<ProductoVO, Integer> carrito = (HashMap<ProductoVO, Integer>) request.getSession()
					.getAttribute("carrito");
			if (carrito == null || carrito.isEmpty()) {
				log.error("Error: El carrito de compra está vacío.");
				response.sendRedirect("error.jsp");
				return;
			}

			if (PedidoServicio.compra(email, carrito, metodoPago)) {
				request.getSession().setAttribute("carrito", null);
			}
			response.sendRedirect("PedidosDESC");
		} catch (Exception e) {
			log.error("Error al realizar la compra: " + e.getMessage());
			response.sendRedirect("error.jsp");
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		doGet(request, response);
	}
}
