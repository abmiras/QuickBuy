import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]

})
export class LoginComponent {
  public usuario = new Usuario();
  public usuarioAutenticado: boolean;

  construtor() {
    this.usuario = new Usuario();
  }
  

  entrarBackup() {
    alert(this.usuario.email + " - " + this.usuario.senha)
  }

  entrar() {
    if (this.usuario.email == "teste@teste.com" && this.usuario.senha == "123456") {
      this.usuarioAutenticado = true;
    }
    else {
      this.usuarioAutenticado = false;
    }
  }

}
