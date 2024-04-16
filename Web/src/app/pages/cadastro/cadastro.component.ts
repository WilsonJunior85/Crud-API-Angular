import { ColaboradorService } from '../../services/colaborador.service';
import { Colaborador } from '../../Models/Colaborador';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';


@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrl: './cadastro.component.css'
})
export class CadastroComponent implements OnInit {
 colaboradores: Colaborador[] = [];
 colaboradoresGeral: Colaborador[] = [];
title = 'Agregamento-App';



constructor(private colaboradorService: ColaboradorService){

}



  ngOnInit(): void {
    this.colaboradorService.GetColaboradores().subscribe(data => {
      //console.log(data);
      const dados = data.dados;

      dados.map((item)=>{
        console.log(item);
      })
      this.colaboradores = data.dados;
      this.colaboradoresGeral = data.dados;

    });
  }

  createColaborador(colaborador: Colaborador){
    this.colaboradorService.createColaborador(colaborador).subscribe((data) => {
      console.log(data);


    })
  }




}













//dados: Colaborador [] =[];

//constructor(private dadoService: DadoService){
 // this.obterDadosCadastrados();
//}

//obterDadosCadastrados(){
//this.dadoService.obterDados()
//.subscribe(dados => this.dados = dados)
//}
