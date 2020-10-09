import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]

})
export class LoginComponent {
  public usuario = new Usuario();
  public usuarioAutenticado: boolean;
  
  constructor(private router: Router) {
    this.usuario = new Usuario();
  }
  

  entrarBackup() {
    alert(this.usuario.email + " - " + this.usuario.senha)
  }

  entrar() {
    if (this.usuario.email == "teste@teste.com" && this.usuario.senha == "123456") {
      this.usuarioAutenticado = true;
      localStorage.setItem("usuario-autenticado", "1");
      this.router.navigate(['/']);
    }
    else {
      this.usuarioAutenticado = false;
    }
  }

}
