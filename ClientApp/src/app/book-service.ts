import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { BookModel } from './books/BookModel';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  private baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  GetBooks() {
    this.http.get<string>("https://localhost:7331/api/v1/book/")
      .subscribe((data: string) => console.log(data));
  }
}
