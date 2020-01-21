import { Component } from "@angular/core";

@Component({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls: ["./login.component.css"]
})
export class LoginComponent {
    
    public titulo = "Quick Buy - Faça suas compras!";
    public email = "";
    public senha = "";

    entrar() {
        if (this.email != "chenpess@gmail.com" || this.senha != "12345") {
            alert('Usuario não cadastrado');
        }
        else {
            alert('Seja bem vindo Claudio');
        }

          
    }

}
