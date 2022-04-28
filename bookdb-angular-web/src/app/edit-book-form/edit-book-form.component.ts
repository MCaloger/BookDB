import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
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
  fileToUpload: string | ArrayBuffer | null | undefined;
  
  handleFileUpload(event:any) {
    const reader = new FileReader();

    reader.readAsDataURL(event.target.files[0]);

    reader.addEventListener('load', () => {
      console.log(reader.result)
      this.fileToUpload = reader.result;
    })
  }

  constructor(private router: Router, private route: ActivatedRoute, private bookService: BookService) { }

  ngOnInit(): void {
    const routeParam = this.route.snapshot.paramMap;
    const idFromRoute = Number(routeParam.get("id"));

    this.bookService.GetBook(idFromRoute).subscribe((data) => {

      this.book = data
      this.bookTitle.setValue(this.book?.title)
      this.bookAuthor.setValue(this.book?.author)
      this.fileToUpload = this.book?.image
    });
  }

  EditBook() {
    const updatedBook = <Book>{
      id: this.book?.id,
      title: this.bookTitle.value,
      author: this.bookAuthor.value,
      image: this.fileToUpload
    };

    this.bookService.UpdateBook(updatedBook).subscribe(
      () => {
        this.router.navigate(["/"])
      }
    );
  }

}
