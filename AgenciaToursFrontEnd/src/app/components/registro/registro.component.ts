import { Component } from '@angular/core';
import { Registro } from './models/registro';
import { RegistroService } from '../registro.service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent {
  registro:Registro = new Registro();
  datatable:any = [];

  constructor(private registroService:RegistroService){

  }

  ngOnInit(): void{
    this.OnDataTable();
  }

  OnDataTable(){
    this.registroService.getAgencia().subscribe(res => {
      this.datatable = res;
      console.log(res);
    });
  }
 
  
  onAddUsuario(registro:Registro):void{
    this.registroService.addUsuario(registro).subscribe(res => {
      if(res){
        alert(`El usuario ${registro.nombre} se ha INGRESADO con exito!`);
        this.clear();
      }else{
        alert(`Error! :(`)
      }
    })
  }


  onSetData(select:any){
    this.registro.id = select.idCliente;
    this.registro.nombre = select.nombre;
    this.registro.apellido = select.apellido;
    this.registro.celular = select.celular;
    this.registro.email = select.email;
    this.registro.contrasena = select.contrasena;
    this.registro.rcontrasena = select.rcontrasena;
}

  clear(){
    this.registro.id = 0;
    this.registro.nombre = "";
    this.registro.apellido = "";
    this.registro.celular = "";
    this.registro.email = "";
    this.registro.contrasena = "";
    this.registro.rcontrasena = "";

  }
}

