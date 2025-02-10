package model.VO;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data @AllArgsConstructor @NoArgsConstructor
public class MostrarValoracionVO {
    private String nombre;
    private String apellido1;
    private String apellido2;
    private String producto;
    private int valoracion;
    private String comentario;
}
