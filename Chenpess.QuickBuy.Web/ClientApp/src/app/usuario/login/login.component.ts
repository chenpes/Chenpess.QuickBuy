import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls: ["./login.component.css"]
})
export class LoginComponent {
    public usuario; 
    
    public titulo = "Quick Buy - Faça suas compras!";
    public usuarioautenticado: boolean;

    constructor() {
        this.usuario = new Usuario();
    }

    entrar() {
        if (this.usuario.email != "chenpess@gmail.com" || this.usuario.senha != "12345") {
            alert('Usuario não cadastrado');
        }
        else {
            this.usuarioautenticado = true;
            alert('Seja bem vindo ' + this.usuario.email + " - " + this.usuario.senha);
        }

          
    }

}
