package service;

import model.DAO.ProveedorDAO;

public class ProveedorServicio {
	public static void bajaProveedor(int id) {
		ProveedorDAO.actualizarBaja(id, true);
	}

	public static void activarProveedor(int id) {
		ProveedorDAO.actualizarBaja(id, false);
	}

}
