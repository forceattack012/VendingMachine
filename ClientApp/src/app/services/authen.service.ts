import { Token } from './../models/token';
import { LoginUser } from './../models/loginUser';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthenService {

  constructor(private httpClient: HttpClient, private jwtHelper: JwtHelperService, private route: Router) { }

  async login(loginUser: LoginUser) {
    const token = await this.httpClient.post<Token>('/api/authentication', loginUser).toPromise();
    localStorage.setItem('token', token.token);

    const user = this.decodeToken();
    const role = user['http://schemas.microsoft.com/ws/2008/06/identity/claims/role']
    if(role === "Admin") {
      this.route.navigate(['/dashboard']);
    }
    else {
      this.route.navigate(['/']);
    }
  }

  isAuthenticated(): boolean {
    const token = localStorage.getItem('token');
    return token !== null && !this.jwtHelper.isTokenExpired(token);
  }

  decodeToken(): any {
    const token = localStorage.getItem('token') ?? '';
    return this.jwtHelper.decodeToken(token);
  }

  getUserRole(): any {
    const token = localStorage.getItem('token');
    if(token === null || token === undefined) {
      return '';
    }

    const user = this.jwtHelper.decodeToken(token);
    const role = user['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'] ?? ''

    return role;
  }
}
