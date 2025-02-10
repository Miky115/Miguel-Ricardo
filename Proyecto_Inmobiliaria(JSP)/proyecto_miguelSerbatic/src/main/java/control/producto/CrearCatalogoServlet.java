package control.producto;

import java.io.IOException;
import java.util.List;
import java.util.Locale;
import java.util.ResourceBundle;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

import model.DAO.CategoriaDAO;
import model.DAO.ConfiguracionDAO;
import model.DAO.ProductoDAO;
import model.DAO.UsuarioDAO;
import model.VO.CategoriaVO;
import model.VO.ConfiguracionVO;
import model.VO.ProductoVO;

@WebServlet("")
public class CrearCatalogoServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	private static Logger log = Logger.getLogger(CrearCatalogoServlet.class);

	public CrearCatalogoServlet() {
		super();
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {

		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);

		try {
			UsuarioDAO.insertarSuperAdmin();
			List<ProductoVO> catalogo = ProductoDAO.getProductosActivos();
			ConfiguracionVO nombreEmpresa = ConfiguracionDAO.getConfiguracion("nombre_empresa");
			ConfiguracionVO cif = ConfiguracionDAO.getConfiguracion("cif");
			ConfiguracionVO telefono = ConfiguracionDAO.getConfiguracion("telefono");
			ConfiguracionVO email = ConfiguracionDAO.getConfiguracion("email");
			ConfiguracionVO provincia = ConfiguracionDAO.getConfiguracion("provincia");
			ConfiguracionVO localidad = ConfiguracionDAO.getConfiguracion("localidad");
			ConfiguracionVO direccion = ConfiguracionDAO.getConfiguracion("direccion");
			ConfiguracionVO logo = ConfiguracionDAO.getConfiguracion("logo_empresa");

			List<CategoriaVO> categorias = CategoriaDAO.selectCategorias();

			request.setAttribute("catalogo", catalogo);
			request.getSession().setAttribute("categorias", categorias);
			request.getSession().setAttribute("nombre_empresa", nombreEmpresa.getValor());
			request.getSession().setAttribute("cif", cif.getValor());
			request.getSession().setAttribute("telefono", telefono.getValor());
			request.getSession().setAttribute("email", email.getValor());
			request.getSession().setAttribute("provincia", provincia.getValor());
			request.getSession().setAttribute("localidad", localidad.getValor());
			request.getSession().setAttribute("direccion", direccion.getValor());
			request.getSession().setAttribute("logo", logo.getValor());
			request.getSession().setAttribute("inicio", null);

			String language = request.getParameter("lang");
			Locale locale;
			if (language != null && language.equals("en")) {
				locale = new Locale("en", "US");
			} else {
				locale = new Locale("es", "ES");
			}
			ResourceBundle rb = ResourceBundle.getBundle("i18n.Idioma", locale);
			request.setAttribute("resourceBundle", rb);
			
			request.getRequestDispatcher("index.jsp").forward(request, response);
		} catch (Exception e) {
			log.error("Error en la obtención del catálogo: " + e.getMessage());
			response.sendRedirect("error.jsp");
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		doGet(request, response);
	}
}
