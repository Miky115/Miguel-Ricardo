package hibernate.VO;

import java.sql.Timestamp;
import java.util.HashSet;
import java.util.Set;
import javax.persistence.*;
import lombok.*;

@Entity
@Table(name = "productos", catalog = "tienda_miguel_serbatic")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Productos implements java.io.Serializable {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id")
    private Integer id;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "id_categoria")
    private Categorias categorias;

    @Column(name = "nombre", length = 255)
    private String nombre;

    @Column(name = "descripcion", length = 255)
    private String descripcion;

    @Column(name = "precio")
    private Double precio;

    @Column(name = "stock")
    private Integer stock;

    @Column(name = "fecha_alta", nullable = false)
    private Timestamp fechaAlta;

    @Column(name = "fecha_baja", nullable = false)
    private Timestamp fechaBaja;

    @Column(name = "impuesto")
    private Float impuesto;

    @Column(name = "imagen", length = 255)
    private String imagen;

    @OneToMany(fetch = FetchType.LAZY, mappedBy = "productos")
    private Set<DetallesPedido> detallesPedidos = new HashSet<>(0);

    @OneToMany(fetch = FetchType.LAZY, mappedBy = "productos")
    private Set<Valoraciones> valoracioneses = new HashSet<>(0);
}
