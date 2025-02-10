package hibernate.VO;

import javax.persistence.*;
import lombok.*;

@Entity
@Table(name = "opciones_menu", catalog = "tienda_miguel_serbatic")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class OpcionesMenu implements java.io.Serializable {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id")
    private Integer id;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "id_rol")
    private Roles roles;

    @Column(name = "nombre_opcion", length = 255)
    private String nombreOpcion;

    @Column(name = "url_opcion", length = 255)
    private String urlOpcion;
}
