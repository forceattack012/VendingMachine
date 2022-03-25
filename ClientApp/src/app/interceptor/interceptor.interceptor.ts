import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { AuthenService } from '../services/authen.service';
import { tap } from "rxjs/operators";
import { LoadingService } from '../services/loading.service';

@Injectable()
export class Interceptor implements HttpInterceptor {

  constructor(private router: Router, private authenService: AuthenService, private loadingService: LoadingService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<any>> {
    const token = localStorage.getItem('token');


    if(token !== null && this.authenService.isAuthenticated()){
      request = request.clone({
        setHeaders: {
          'Content-Type': 'application/json',
           Authorization: 'Bearer ' +token
        }
      })
    }
    return next.handle(request).pipe(tap(() => {
      this.loadingService.isLoading.emit(false);
    },
      (err:any) => {
        this.loadingService.isLoading.emit(false);
        if (err instanceof HttpErrorResponse) {
          if (err.status !== 401) {
            return;
           }
           this.router.navigate(['login']);
        }
      }
    ));
  }
}

