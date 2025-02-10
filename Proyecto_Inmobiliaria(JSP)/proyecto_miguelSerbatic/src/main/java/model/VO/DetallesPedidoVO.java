package model.VO;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class DetallesPedidoVO {
	int id;
	int idPedido;
	int idProducto;
	double precioUnidad;
	int unidades;
	double impuesto;
	double total;
}
