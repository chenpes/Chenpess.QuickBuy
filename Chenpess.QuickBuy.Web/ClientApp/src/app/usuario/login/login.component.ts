import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";

@Component({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {

    public usuario;
    public returnUrl: string;

    public titulo = "Quick Buy - Faça suas compras!";
    public usuarioautenticado: boolean;

    constructor(private router: Router, private actvatedRouter: ActivatedRoute) {

    }

    ngOnInit(): void {
        this.returnUrl = this.actvatedRouter.snapshot.queryParams['returnUrl'];
        this.usuario = new Usuario();
    }

    entrar() {
        if (this.usuario.email == "chenpess@gmail.com" && this.usuario.senha == "12345") {
            this.usuarioautenticado = true;
            sessionStorage.setItem("usuario-autenticado", "1")
            this.router.navigate([this.returnUrl]);
        }
        else {
            alert('Usuario não cadastrado');

        }
    }

}
