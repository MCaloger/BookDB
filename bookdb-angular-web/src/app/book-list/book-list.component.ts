import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { BookService } from '../book.service';
import { Book } from '../book/book.model';


@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.scss']
})
export class BookListComponent implements OnInit {

  books: Observable<Book[]> = new Observable<[]>();
  
  constructor( private bookService: BookService ) { }

  ngOnInit(): void {
    this.books = this.bookService.GetBooks();
  }

  
}
