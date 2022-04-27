import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
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

  GetBook(id: number) {
    return this.http.get<Book>(`https://localhost:7247/api/v1/book/${id}`).pipe();
  }

  CreateBook(book?: Book): Observable<Book> {
    if (book?.id != undefined) {
      book.id = undefined;
    }
    return this.http.post<Book>(`https://localhost:7247/api/v1/book/create`, book);

  }

  UpdateBook(book?: Book): Observable<Book> {
    return this.http.put<Book>(`https://localhost:7247/api/v1/book/update`, book);
  }
}
