package control.configuracion;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

import model.DAO.ConfiguracionDAO;

@WebServlet("/editarConfiguracion")
public class EditarConfiguracionServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(EditarConfiguracionServlet.class);

    public EditarConfiguracionServlet() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		response.sendRedirect("configuracion.jsp");
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
        PropertyConfigurator.configure(log4jPath);
        try {
            String nombre = request.getParameter("nombre");
            String direccion = request.getParameter("direccion");
            String localidad = request.getParameter("localidad");
            String provincia = request.getParameter("provincia");
            String telefono = request.getParameter("telefono");
            String cif = request.getParameter("cif");
            String email = request.getParameter("email");
            String logo = request.getParameter("logo");
            
            ConfiguracionDAO.updateConfiguracion("nombre_empresa", nombre);
            ConfiguracionDAO.updateConfiguracion("direccion", direccion);
            ConfiguracionDAO.updateConfiguracion("localidad", localidad);
            ConfiguracionDAO.updateConfiguracion("provincia", provincia);
            ConfiguracionDAO.updateConfiguracion("telefono", telefono);
            ConfiguracionDAO.updateConfiguracion("cif", cif);
            ConfiguracionDAO.updateConfiguracion("email", email);
            ConfiguracionDAO.updateConfiguracion("logo_empresa", logo);

            request.getSession().setAttribute("nombre_empresa", nombre);
    		request.getSession().setAttribute("cif", cif);
    		request.getSession().setAttribute("telefono", telefono);
    		request.getSession().setAttribute("email", email);
    		request.getSession().setAttribute("provincia", provincia);
    		request.getSession().setAttribute("localidad", localidad);
    		request.getSession().setAttribute("direccion", direccion);
    		request.getSession().setAttribute("logo", logo);
            
            response.sendRedirect("configuracion.jsp");
  
        } catch (Exception e) {
            log.error("Error al editar el proveedor: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }
	}