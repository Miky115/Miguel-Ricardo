package model.VO;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data @AllArgsConstructor @NoArgsConstructor
public class ProveedorVO {
	int id;
	String nombre;
	String direccion;
	String localidad;
	String provincia;
	String telefono;
	String cif;
	String email;
	boolean baja;
}
