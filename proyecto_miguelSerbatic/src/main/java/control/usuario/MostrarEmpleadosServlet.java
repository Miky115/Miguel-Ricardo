package control.usuario;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.VO.UsuarioVO;
import service.UsuarioServicio;

import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/mostrarEmpleados")
public class MostrarEmpleadosServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(MostrarEmpleadosServlet.class);

    public MostrarEmpleadosServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
		String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
		PropertyConfigurator.configure(log4jPath);
        try {
            List<UsuarioVO> empleados = UsuarioServicio.verEmpleados();
            request.setAttribute("usuarios", empleados);
            request.getSession().setAttribute("cliente", "empleado");
            request.getRequestDispatcher("gestionUsuarios.jsp").forward(request, response);
        } catch (Exception e) {
            log.error("Error al obtener la lista de empleados", e);
            response.sendRedirect("error.jsp");
        }
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
    	UsuarioVO usuario = new UsuarioVO();
		usuario.setEmail(request.getParameter("email"));
		usuario.setClave(request.getParameter("clave"));
		usuario.setNombre(request.getParameter("nombre"));
		usuario.setApellido1(request.getParameter("apellido1"));
		usuario.setApellido2(request.getParameter("apellido2"));
		usuario.setDireccion(request.getParameter("direccion"));
		usuario.setProvincia(request.getParameter("provincia"));
		usuario.setLocalidad(request.getParameter("localidad"));
		usuario.setTelefono(request.getParameter("telefono"));
		usuario.setDni(request.getParameter("dni"));
    	UsuarioServicio.crearEmpleados(usuario);
    	response.sendRedirect("mostrarEmpleados");
    }
}
