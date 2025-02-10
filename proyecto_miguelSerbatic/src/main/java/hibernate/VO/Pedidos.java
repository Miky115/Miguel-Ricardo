package hibernate.VO;

import java.sql.Timestamp;
import java.util.HashSet;
import java.util.Set;
import javax.persistence.*;
import lombok.*;

@Entity
@Table(name = "pedidos", catalog = "tienda_miguel_serbatic")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Pedidos implements java.io.Serializable {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id")
    private Integer id;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "id_usuario")
    private Usuarios usuarios;

    @Column(name = "fecha", nullable = false)
    private Timestamp fecha;

    @Column(name = "metodo_pago", length = 255)
    private String metodoPago;

    @Column(name = "estado", length = 255)
    private String estado;

    @Column(name = "num_factura", length = 255)
    private String numFactura;

    @Column(name = "total")
    private Double total;

    @OneToMany(fetch = FetchType.LAZY, mappedBy = "pedidos")
    private Set<DetallesPedido> detallesPedidos = new HashSet<>(0);
}
