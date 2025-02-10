package control.producto;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.DAO.ProductoDAO;
import model.VO.ProductoVO;
import service.ProductoServicio;

/**
 * Servlet implementation class ImportarExcelServlet
 */
@WebServlet("/importarExcel")
public class ImportarExcelServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ImportarExcelServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		List<ProductoVO> productos = ProductoServicio.readProductsFromExcel("C:/Users/migue/Serbatic/proyecto_miguelSerbatic/ficheros/productos.xls");
        ProductoDAO.insertProductsIntoDatabase(productos);
        System.out.println("Productos insertados en la base de datos correctamente.");
        response.sendRedirect("mostrarProductos");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
