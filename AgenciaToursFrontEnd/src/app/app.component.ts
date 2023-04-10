import { Component } from '@angular/core';
//import { Agencia } from './models/agencia';
//import { AgenciaService } from './services/agencia.service';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  // agencia:Agencia = new Agencia();
  // datatable:any = [];

  // constructor(private agenciaService:AgenciaService){

  }

//   ngOnInit(): void{
//     this.OnDataTable();
//   }

//   OnDataTable(){
//     this.agenciaService.getAgencia().subscribe(res => {
//       this.datatable = res;
//       console.log(res);
//     });
//   }

//   onAddCliente(agencia:Agencia):void{
//     this.agenciaService.addAgencia(agencia).subscribe(res => {
//       if(res){
//         alert(`El cliente ${agencia.nombre} se ha INGRESADO con exito!`);
//         this.clear();
//         this.OnDataTable();
//       }else{
//         alert(`Error! :(`)
//       }
//     })
//   }

//   onUpdateCliente(agencia:Agencia): void{
//     this.agenciaService.updateAgencia(agencia.id, agencia).subscribe(res => {
//       if(res){
//         alert(`El cliente ${agencia.nombre} se ha ACTUALIZADO con exito!`);
//         this.clear();
//         this.OnDataTable();
//       }else{
//         alert(`Error! :(`)
//       }
//     })
//   }

//   onDeleteCliente(id:number, agencia:Agencia):void{
//     this.agenciaService.deleteAgencia(id).subscribe(res => {
//       if(res){
//         alert(`El cliente ${agencia.nombre} se ha ELMINADO con exito!`);
//         this.clear();
//         this.OnDataTable();
//       }else{
//         alert(`Error! :(`)
//       }
//     })
//   }

//   onSetData(select:any){
//       this.agencia.id = select.idCliente;
//       this.agencia.nombre = select.nombre;
//       this.agencia.apellido = select.apellido;
//       this.agencia.cedula = select.cedula;
//       this.agencia.email = select.email;
//       this.agencia.celular = select.celular;
//   }

//   clear(){
//     this.agencia.id = 0;
//     this.agencia.nombre = "";
//     this.agencia.apellido = "";
//     this.agencia.cedula = "";
//     this.agencia.email = "";
//     this.agencia.celular = "";

//   }
// }
