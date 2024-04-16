import { ColaboradorService } from './../../services/colaborador.service';
import { Response } from './../../Models/Response';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Colaborador } from '../../Models/Colaborador';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cadastro-form',
  templateUrl: './cadastro-form.component.html',
  styleUrl: './cadastro-form.component.css'
})
export class CadastroFormComponent implements OnInit{
logos: string = "/Agregamento-App/src/assets/img/Serede_logo cor.png";

//Mandando o formulário para fora
@Output() onSubmit = new EventEmitter<Colaborador>();
//Formulário
cadastroForm!: FormGroup;



constructor( private colaboradorService: ColaboradorService,   private router: Router){}


  ngOnInit(): void {

//Carregando a página do formulário
this.cadastroForm = new FormGroup({
  idSerede: new FormControl(0),
   nome: new FormControl(''),
  situacaoDoColaborador: new FormControl(true),
   cpf: new FormControl(''),
   pis: new FormControl(''),
   centroDeCusto: new FormControl(''),
   cargo: new FormControl(''),
   estado: new FormControl(''),
   gestor: new FormControl(''),
 });

  }



submit(){

//console.log(this.cadastroForm.value);
this.onSubmit.emit(this.cadastroForm.value);


}

}



