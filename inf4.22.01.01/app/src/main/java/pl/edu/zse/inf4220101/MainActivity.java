package pl.edu.zse.inf4220101;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    TextView message;
    EditText email;
    EditText password;
    EditText repeatPassword;
    Button accept;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        message = findViewById(R.id.message);
        email = findViewById(R.id.email);
        password = findViewById(R.id.password);
        repeatPassword = findViewById(R.id.repeatpassword);
        accept = findViewById(R.id.accept);

        message.setText("Autor: PESEL");

        accept.setOnClickListener(new View.OnClickListener() {
              @Override
              public void onClick(View view) {
                  if(!(email.getText().toString()).contains("@")){
                     message.setText(("Nieprawidłowy adres email"));
                  } else if (!password.getText().toString().equals(repeatPassword.getText().toString())) {
                      message.setText("Hasła się różnią");
                  }else{
                      message.setText(String.format("Witaj %s", email.getText()));
                  }
              }
          }

        );


    }
}