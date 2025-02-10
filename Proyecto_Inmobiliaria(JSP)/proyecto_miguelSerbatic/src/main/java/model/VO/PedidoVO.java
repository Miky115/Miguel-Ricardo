package model.VO;

import java.sql.Timestamp;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class PedidoVO {
	int id;
	int idUsuario;
	Timestamp fecha;
	String metodoPago;
	String estado;
	String numFactura;
	double total;
}
