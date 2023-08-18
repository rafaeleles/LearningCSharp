import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {

  public eventos: any;

  constructor(private http: HttpClient) {

  }

  ngOnInit() : void {
    this.getEventos();
  }

  public getEventos(): void {

      this.http.get('https://localhost:5001/api/Evento').subscribe(
        response => this.eventos = response,
        error => console.log(error)
      )

    // this.eventos = [
    //   {
    //     Tema: "Angular",
    //     Local: "São Paulo"
    //   },
    //   {
    //     Tema: "Vue",
    //     Local: "Belo Horizonte"
    //   },
    //   {
    //     Tema: "React",
    //     Local: "Rio de Janeiro"
    //   }
    // ]
    
  }

}
