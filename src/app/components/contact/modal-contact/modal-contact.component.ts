import { Component, Input} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgbActiveModal } from "@ng-bootstrap/ng-bootstrap";
import { ToastService } from '../../../services/toast.service';

@Component({
  selector: 'app-modal-contact',
  templateUrl: './modal-contact.component.html',
  styleUrl: './modal-contact.component.scss'
})
export class ModalContactComponent {
  @Input() public id_contact: any;
  modal = {} as any;  showError = false;

  constructor(private http: HttpClient, public activeModal: NgbActiveModal, private toast: ToastService) { }

  ngOnInit(): void { 
    this.http.get('http://localhost:5080/api/contacts').subscribe(( res:any ) => {
      this.modal= res[0];
    })
  };

  save(){
    this.http.put(`http://localhost:5080/api/contacts/${this.id_contact}`, this.modal).subscribe(() => {
      this.activeModal.close(),
      window.location.reload(),
      this.toast.success('Modificare contact cu succes!');
    },
      (error) => {
        console.log("Eroare la salvare ", error);
      }
    );
  };
}
