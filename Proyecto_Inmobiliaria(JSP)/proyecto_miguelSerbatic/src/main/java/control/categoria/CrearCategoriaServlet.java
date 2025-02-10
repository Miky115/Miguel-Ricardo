package control.categoria;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.CategoriaDAO;
import model.VO.CategoriaVO;
import org.apache.log4j.Logger;
import org.apache.log4j.PropertyConfigurator;

@WebServlet("/CrearCategoria")
public class CrearCategoriaServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;
    private static Logger log = Logger.getLogger(CrearCategoriaServlet.class);

    public CrearCategoriaServlet() {
        super();
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String log4jPath = getServletContext().getRealPath("/") + "ficheros/log4j.properties";
        PropertyConfigurator.configure(log4jPath);
        try {
            String nombre = request.getParameter("nombre");
            String descripcion = request.getParameter("descripcion");

            if (nombre != null && !nombre.isEmpty() && descripcion != null && !descripcion.isEmpty()) {
                CategoriaVO categoria = new CategoriaVO();
                categoria.setNombre(nombre);
                categoria.setDescripcion(descripcion);

                CategoriaDAO.insertCategoria(categoria);

                response.sendRedirect("mostrarCategorias");
            } else {
                response.sendRedirect("error.jsp");
            }
        } catch (Exception e) {
            log.error("Error al crear la categoría: " + e.getMessage());
            response.sendRedirect("error.jsp");
        }
    }
}
