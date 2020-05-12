import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router } from "@angular/router";

@Component({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls: ["./login.component.css"]
})
export class LoginComponent {
    public usuario; 
    
    public titulo = "Quick Buy - Faça suas compras!";
    public usuarioautenticado: boolean;

    constructor(private router: Router) {
        this.usuario = new Usuario();
    }

    entrar() {
        if (this.usuario.email != "chenpess@gmail.com" || this.usuario.senha != "12345") {
            alert('Usuario não cadastrado');
        }
        else {
            this.usuarioautenticado = true;
            localStorage.setItem("usuario-autenticado","1")
            alert('Seja bem vindo ' + this.usuario.email + " - " + this.usuario.senha);
            this.router.navigate(['/']);
        }

          
    }

}
