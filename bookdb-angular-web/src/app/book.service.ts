import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Book } from './book/book.model';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private http: HttpClient) { }

  books: Book[] = [];

  GetBooks() {
    return this.http.get<Book[]>("https://localhost:7247/api/v1/book/books");
  }
}
