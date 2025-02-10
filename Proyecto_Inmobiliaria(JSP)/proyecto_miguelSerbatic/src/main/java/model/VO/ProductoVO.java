package model.VO;

import java.sql.Timestamp;

import lombok.*;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class ProductoVO {

	int id;
	int idCategoria;
	String nombre;
	String descripcion;
	Double precio;
	int stock;
	Double impuestos;
	String imagen;	
	Timestamp fechaAlta;
	Timestamp fechaBaja;
	private boolean baja;
}
