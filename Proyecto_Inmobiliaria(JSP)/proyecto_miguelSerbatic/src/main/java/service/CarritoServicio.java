package service;

import java.text.ParseException;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

import model.DAO.ProductoDAO;
import model.VO.ProductoVO;

public class CarritoServicio {

	public static void quitarCarrito(HashMap<ProductoVO, Integer> carrito, String id) {

		ProductoVO producto = ProductoDAO.obtenerPorId(Integer.parseInt(id));

		carrito.remove(producto);

	}

	public static void quitarCantidad(HashMap<ProductoVO, Integer> carrito, String id) {
		ProductoVO producto = ProductoDAO.obtenerPorId(Integer.parseInt(id));
		if (carrito.containsKey(producto)) {
			int cantidadExistente = carrito.get(producto);
			if (cantidadExistente > 1) {
				carrito.put(producto, cantidadExistente - 1);
			} else {
				carrito.remove(producto);
			}
		}
	}

	public static void introducirCarrito(HashMap<ProductoVO, Integer> carrito, String id) {

		ProductoVO producto = ProductoDAO.obtenerPorId(Integer.parseInt(id));

		if (carrito.containsKey(producto)) {
			int cantidadExistente = carrito.get(producto);
			carrito.put(producto, cantidadExistente + 1);
		} else {
			carrito.put(producto, 1);
		}
	}
}