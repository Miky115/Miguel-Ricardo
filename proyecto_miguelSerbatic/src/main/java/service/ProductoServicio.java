package service;

import java.io.File;
import java.io.IOException;
import java.sql.Timestamp;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

import jxl.Cell;
import jxl.Sheet;
import jxl.Workbook;
import jxl.read.biff.BiffException;
import jxl.write.Label;
import jxl.write.WritableSheet;
import jxl.write.WritableWorkbook;
import jxl.write.WriteException;
import model.DAO.ProductoDAO;
import model.VO.ProductoVO;

public class ProductoServicio {

	public static void bajaProducto(int idProducto) {
		ProductoDAO.actualizarBaja(idProducto, true);
	}

	public static void activarProducto(int idProducto) {
		ProductoDAO.actualizarBaja(idProducto, false);
	}

	public static void writeProductsToExcel(String fileName) {
		WritableWorkbook workbook;
		List<ProductoVO> productos = ProductoDAO.getProductos();
		try {
			workbook = Workbook.createWorkbook(new File(fileName));
			WritableSheet sheet = workbook.createSheet("Productos", 0);

			sheet.addCell(new Label(0, 0, "ID Categoría"));
			sheet.addCell(new Label(1, 0, "Nombre"));
			sheet.addCell(new Label(2, 0, "Descripción"));
			sheet.addCell(new Label(3, 0, "Precio"));
			sheet.addCell(new Label(4, 0, "Stock"));
			sheet.addCell(new Label(5, 0, "Impuesto"));
			sheet.addCell(new Label(6, 0, "Fecha Alta"));
			sheet.addCell(new Label(7, 0, "Baja"));
			sheet.addCell(new Label(8, 0, "Imagen"));

			int rowNum = 1;
			for (ProductoVO producto : productos) {
				sheet.addCell(new Label(0, rowNum, String.valueOf(producto.getIdCategoria())));
				sheet.addCell(new Label(1, rowNum, producto.getNombre()));
				sheet.addCell(new Label(2, rowNum, producto.getDescripcion()));
				sheet.addCell(new Label(3, rowNum, String.valueOf(producto.getPrecio() + "€")));
				sheet.addCell(new Label(4, rowNum, String.valueOf(producto.getStock())));
				sheet.addCell(new Label(5, rowNum, String.valueOf(producto.getImpuestos())));
				sheet.addCell(new Label(6, rowNum, producto.getFechaAlta().toString()));
				sheet.addCell(new Label(7, rowNum, Boolean.toString(producto.isBaja())));
				sheet.addCell(new Label(8, rowNum, producto.getImagen()));
				rowNum++;
			}

			workbook.write();
			workbook.close();
		} catch (IOException | WriteException e) {
			e.printStackTrace();
		}
	}

	public static List<ProductoVO> readProductsFromExcel(String fileName) {
		List<ProductoVO> lista = new ArrayList<>();
		try {
			Workbook workbook = Workbook.getWorkbook(new File(fileName));
			Sheet sheet = workbook.getSheet(0);

			for (int i = 1; i < sheet.getRows(); i++) {
				Cell[] row = sheet.getRow(i);
				ProductoVO producto = new ProductoVO();

				producto.setIdCategoria(Integer.parseInt(row[0].getContents()));
				producto.setNombre(row[1].getContents());
				producto.setDescripcion(row[2].getContents());
				producto.setPrecio(Double.parseDouble(row[3].getContents().replace("€", "")));
				producto.setStock(Integer.parseInt(row[4].getContents()));
				producto.setImpuestos(Double.parseDouble(row[5].getContents()));
				producto.setFechaAlta(parseTimestamp(row[6].getContents()));
				producto.setBaja(Boolean.parseBoolean(row[7].getContents()));
				producto.setImagen(row[8].getContents());
				lista.add(producto);
			}

			workbook.close();
		} catch (IOException | BiffException | ParseException e) {
			e.printStackTrace();
		}
		return lista;
	}

	public static Timestamp parseTimestamp(String dateString) throws ParseException {
		SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
		Date parsedDate = dateFormat.parse(dateString);
		return new Timestamp(parsedDate.getTime());
	}

}
