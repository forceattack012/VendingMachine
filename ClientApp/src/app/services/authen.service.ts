import { Token } from './../models/token';
import { LoginUser } from './../models/loginUser';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthenService {

  constructor(private httpClient: HttpClient, private jwtHelper: JwtHelperService) { }

  async login(loginUser: LoginUser) {
    const token = await this.httpClient.post<Token>('/api/authentication', { loginUser }).toPromise();
    localStorage.setItem('token', token.token);
  }

  isAuthenticated(): boolean {
    const token = localStorage.getItem('token');
    return token !== null && !this.jwtHelper.isTokenExpired(token);
  }
}
