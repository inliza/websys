import { Component } from '@angular/core';
import { ClientModel } from './models/client';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public Client: ClientModel;
  public ClientList: ClientModel[] = [];
  constructor(
  ) {
    this.Client = new ClientModel();
  }
  title = 'angular-crud';

  public Save() {
    let client =  this.ClientList.find(element => element.email == this.Client.email);
    if(client){
      alert("Error! Este correo ya existe.");
      return;
    }
   
    this.Client.id = this.ClientList.length + 1;
    this.ClientList.push(this.Client);
    this.Client = new ClientModel();
    alert("Cliente guardado correctamente");
  }

  public Delete(id) {
  let client =  this.ClientList.find(element => element.id == id);
    const index = this.ClientList.indexOf(client);
    if (index > -1) {
      this.ClientList.splice(index, 1);
    }
    alert("Cliente borrado correctamente");
  }
}
