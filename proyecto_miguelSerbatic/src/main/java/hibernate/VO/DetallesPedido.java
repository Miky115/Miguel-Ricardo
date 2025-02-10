package hibernate.VO;

import javax.persistence.*;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Table(name = "detalles_pedido", catalog = "tienda_miguel_serbatic")
@Data @AllArgsConstructor @NoArgsConstructor
public class DetallesPedido implements java.io.Serializable {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id")
    private Integer id;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "id_producto")
    private Productos productos;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "id_pedido")
    private Pedidos pedidos;

    @Column(name = "precio_unidad")
    private Float precioUnidad;

    @Column(name = "unidades")
    private Integer unidades;

    @Column(name = "impuesto")
    private Float impuesto;

    @Column(name = "total")
    private Double total;
}
