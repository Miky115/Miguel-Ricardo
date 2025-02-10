package control.categoria;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.CategoriaDAO;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/eliminarCategoria")
public class EliminarCategoriaServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(EliminarCategoriaServlet.class);

	public EliminarCategoriaServlet() {
		super();
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
        String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
        PropertyConfigurator.configure(log4jPath);
		try {
			String id = request.getParameter("id");
			if (id != null && !id.isEmpty()) {
				CategoriaDAO.deleteCategoria(Integer.parseInt(id));
				response.sendRedirect("mostrarCategorias");
			} else {
				response.sendRedirect("error.jsp");
			}
		} catch (Exception e) {
			log.error("Error al eliminar la categoría: " + e.getMessage());
			response.sendRedirect("error.jsp");
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		doGet(request, response);
	}
}
