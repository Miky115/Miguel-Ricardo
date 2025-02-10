package model.VO;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data @AllArgsConstructor @NoArgsConstructor
public class ValoracionVO {
	int id;
	int idProducto;
	int idUsuario;
	int valoracion;
	String comentario;
}
