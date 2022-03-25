import { Injectable } from '@angular/core';
import * as signalR from '@microsoft/signalr';

@Injectable({
  providedIn: 'root'
})
export class AdminHubService {

  private hubConnection: signalR.HubConnection | undefined;

  constructor() {
  }

  public startConnection = () => {
    const baseUrl = 'ws://localhost:5295/adminHub';
    //'ws://localhost:7000/gateway/basketHub'
    const token = localStorage.getItem('token') ?? '';
    this.hubConnection = new signalR.HubConnectionBuilder()
    .withUrl(baseUrl, {
      accessTokenFactory: () => {
        return token;
      },
      skipNegotiation: true,
      transport: signalR.HttpTransportType.WebSockets
    })
    .build();

    this.hubConnection
    .start()
    .then(() => console.log('connection started'))
    .catch(err => console.log('Error start connection hub ' + err));

    return this.hubConnection;
  }
}
