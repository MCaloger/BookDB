import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { BookService } from '../book.service';
import { Book } from '../book/book.model';

@Component({
  selector: 'app-edit-book-form',
  templateUrl: './edit-book-form.component.html',
  styleUrls: ['./edit-book-form.component.scss']
})
export class EditBookFormComponent implements OnInit {
  book: Book | undefined;

  bookTitle = new FormControl('');
  bookAuthor = new FormControl('');

  constructor(private route: ActivatedRoute, private bookService: BookService) { }

  ngOnInit(): void {
    const routeParam = this.route.snapshot.paramMap;
    const idFromRoute = Number(routeParam.get("id"));

    this.bookService.GetBook(idFromRoute).subscribe((data) => {

      this.book = data
      this.bookTitle.setValue(this.book?.title)
      this.bookAuthor.setValue(this.book?.author)
    });

    
  }

  EditBook() {
    const updatedBook = <Book>{
      id: this.book?.id,
      title: this.bookTitle.value,
      author: this.bookAuthor.value
    };

    this.bookService.UpdateBook(updatedBook).subscribe();
  }

}
