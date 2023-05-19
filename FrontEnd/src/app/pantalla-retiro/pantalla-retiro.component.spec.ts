import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PantallaRetiroComponent } from './pantalla-retiro.component';

describe('PantallaRetiroComponent', () => {
  let component: PantallaRetiroComponent;
  let fixture: ComponentFixture<PantallaRetiroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PantallaRetiroComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PantallaRetiroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
