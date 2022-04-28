import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { BookService } from '../book.service';
import { Book } from '../book/book.model'

@Component({
  selector: 'app-add-book-form',
  templateUrl: './add-book-form.component.html',
  styleUrls: ['./add-book-form.component.scss']
})
export class AddBookFormComponent implements OnInit {

  bookTitle = new FormControl('');
  bookAuthor = new FormControl('');

  

  constructor( private bookService: BookService, private router: Router ) { }

  ngOnInit(): void {
  }

  CreateBook() {
    console.log("test");
    let book: Book = <Book>{ title: this.bookTitle.value, author: this.bookAuthor.value };
    this.bookService.CreateBook(book).subscribe(() => {
      this.router.navigate(["/"])
    });
  }

}
