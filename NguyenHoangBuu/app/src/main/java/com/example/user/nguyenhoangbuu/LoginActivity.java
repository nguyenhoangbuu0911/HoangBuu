package com.example.user.nguyenhoangbuu;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class LoginActivity extends AppCompatActivity {

    EditText edtUsername;
    EditText edtPassword;
    Button btnLogin;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        onInit();
        onValidateForm();

        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (onValidateForm()){
                    if (edtUsername.getText().toString().equals("buu") && edtPassword.getText().toString().equals("buu")){
                        Toast.makeText(LoginActivity.this, "Login Success", Toast.LENGTH_LONG).show();
                        Intent i = new Intent(LoginActivity.this,MainActivity.class);
                        startActivity(i);
                    }
                    else {
                        Toast.makeText(LoginActivity.this, "Login Fail/", Toast.LENGTH_LONG ).show();
                    }
                }
            }
        });
    }

    private  boolean onValidateForm(){
        if(edtUsername.getText().toString().length() < 1){
            edtUsername.setError("Please fill username");
            return false;
        }
        if(edtPassword.getText().toString().length() <1){
            edtPassword.setError("Please fill password");
            return false;
        }
        return true;
    }

    private void onInit() {
        edtUsername = findViewById(R.id.Main_edtUsername);
        edtPassword = findViewById(R.id.Main_edtPassword);
        btnLogin = findViewById(R.id.Main_btnLogin);
    }

}
