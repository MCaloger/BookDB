import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { BookService } from '../book.service';
import { Book } from '../book/book.model';


@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.scss']
})
export class BookListComponent implements OnInit {

  books?: Book[] | undefined;
  
  constructor( private bookService: BookService ) { }

  ngOnInit(): void {
    this.GetBooks();
  }

  GetBooks() {
    this.bookService.GetBooks().subscribe(
      data => {
        this.books = data;
      }
    );
  }

  remove(event: any) {
    this.bookService.DeleteBook(event.target.id).subscribe(() => {
      this.GetBooks();
    });
  }
}
