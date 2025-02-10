package hibernate.VO;

import java.sql.Timestamp;
import javax.persistence.*;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Table(name = "descuentos", catalog = "tienda_miguel_serbatic")
@Data @AllArgsConstructor @NoArgsConstructor
public class Descuentos implements java.io.Serializable {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id")
    private Integer id;

    @Column(name = "codigo", length = 255)
    private String codigo;

    @Column(name = "descuento")
    private Float descuento;

    @Column(name = "fecha_inicio", nullable = false)
    private Timestamp fechaInicio;

    @Column(name = "fecha_fin", nullable = false)
    private Timestamp fechaFin;

}
