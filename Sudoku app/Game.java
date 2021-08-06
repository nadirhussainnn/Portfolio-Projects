import java.util.Random;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import javax.sound.sampled.*;
import java.io.*;

class Game{
	
	static JFrame f;
	static JTextField entry[][];
	
	static JLabel showTime;
	static Font font;
		
	static JButton mute;
	static JButton shuffle;
	static JButton solution;
	static JButton exit;
	
	static String isItFirstTime;
	static int random[];
	
	static int minute, second, x;
		
	static AudioInputStream ais;
	static Clip clip;
	
	static ImageIcon ic1;
	static ImageIcon ic2;
	static ImageIcon ic3;
	
	static JLabel playerPic;
	static Boolean alreadyExists, isItRunning;
	
	static Thread bgMusic;
	static Thread timeChecker;
	
	public static void main(String arguments[]){
	}
	public static void designGame(String n, String c){
		
		f=new JFrame("Sudoku");
		entry=new JTextField[9][9];
		showTime=new JLabel();
		font=new Font("Courier",Font.BOLD,22);	
		mute=new JButton("Mute");			
		shuffle=new JButton("Shuffle");
		solution=new JButton("See Solution");
		exit=new JButton("Exit");
		isItFirstTime="YES";
		minute=second=x=0;
		ic1=new ImageIcon("On2.png");
		ic2=new ImageIcon("Off.png");
		ic3=new ImageIcon("PersonC.png");
		playerPic=new JLabel();
		alreadyExists=false;
		isItRunning=true;

		f.setSize(750,600);
		f.setResizable(false);
		f.setLocationRelativeTo(null);
		f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		f.setLayout(null);
		f.getContentPane().setBackground(Color.BLACK);
		
		if(c.equals("EASY")){
			random=new int[]{1,2,3,4,5,6,7,8,9,1,2,3,4,5,6,7,8,9};
			minute=29;
			second=59;
		}
		else if(c.equals("MEDIUM")){
			random=new int[]{1,2,3,4,5,6,7,8,9,1,2,3,4,5,6,7,8,9,1,2,3,4,5,6,7,8,9};
			minute=24;
			second=59;
		}
		else if(c.equals("DIFFICULT")){
			random=new int[]{1,2,3,4,5,6,7,8,9,1,2,3,4,5,6,7,8,9,1,2,3,4,5,6,7,8,9,1,2,3,4,5,6,7};
			minute=19;
			second=59;
		}
		drawBoxes();
		setRandoms();	
		
		playerPic.setBounds(20,50,ic3.getIconWidth(),ic3.getIconHeight());
		playerPic.setIcon(ic3);
		playerPic.setOpaque(false);	
		f.add(playerPic);
		showTime.setBounds(40,400,170,100);
		showTime.setText("<html><font color=aqua>Time</font><font color=red>"+minute+" : "+second);
		
		JLabel name=new JLabel(n);
		JLabel level=new JLabel(c);
		
		
		name.setBounds(20,ic3.getIconHeight()+60,250,30);
		level.setBounds(20,ic3.getIconHeight()+100,200,30);
		
		name.setFont(font);
		level.setFont(font);
		name.setForeground(Color.WHITE);
		level.setForeground(Color.WHITE);
		
		mute.setIcon(ic1);
		mute.setBorderPainted(false);
		mute.setContentAreaFilled(false);
		
		mute.setBounds(605,35,ic1.getIconWidth(),ic1.getIconHeight());
		solution.setBounds(40,490,120,30);
		shuffle.setBounds(500,490,80,30);
		exit.setBounds(600,490,74,30);
	
		mute.addActionListener(new ButtonListener());
		shuffle.addActionListener(new ButtonListener());
		exit.addActionListener(new ButtonListener());
		solution.addActionListener(new ButtonListener());
		
		bgMusic=new Thread(new BackgroundMusic());	
		bgMusic.start();
		
		timeChecker=new Thread(new Timer());
		timeChecker.start();
		
		showTime.setFont(font);
		
		Thread checkResult=new Thread(new Result());
		checkResult.start();		
			
		f.add(mute);
		f.add(shuffle);
		f.add(exit);
		f.add(showTime);
		f.add(solution);	
		f.add(name);
		f.add(level);
		f.setVisible(true);
	}
	public static void drawBoxes(){
	
		int x_axis=300,y_axis=80, length=40, height=40;
		for(int i=0;i<9;i++){
			for(int j=0;j<9;j++){
				entry[i][j]=new JTextField(1);
				entry[i][j].setBounds(x_axis, y_axis, length, height);
				entry[i][j].setHorizontalAlignment(JTextField.CENTER);
				entry[i][j].setFont(font);
				entry[i][j].setBackground(Color.CYAN);
				entry[i][j].addKeyListener(new FieldListener());
				f.add(entry[i][j]);
				x_axis+=length+2;
			}
			x_axis=300;
			y_axis+=height+2;
		}
	}
	
	public static void makeBoxesEmpty(){
		for(int i=0;i<9;i++){
			for(int j=0;j<9;j++){
				entry[i][j].setText("");
				entry[i][j].setEnabled(true);
				entry[i][j].setBackground(Color.CYAN);
				entry[i][j].setForeground(Color.BLUE);	
			}
		}
	}
	public static void setRandoms(){
		makeBoxesEmpty();

		int randomPositionX=0, randomPositionY=0;
		Random rand=new Random();
		while(x<random.length){
				
			randomPositionX=(int)(9*rand.nextDouble());
			randomPositionY=(int)(9*rand.nextDouble());
			
			alreadyExists=false;
			for(int i=0;i<9;i++){
	 			int inLine=0, inCol=0;
				if(entry[randomPositionX][i].getText().length()>0){
					inLine=Integer.parseInt(entry[randomPositionX][i].getText());			
				}
				if(entry[i][randomPositionY].getText().length()>0){
					inCol=Integer.parseInt(entry[i][randomPositionY].getText());
				}
				if(inLine==random[x] || inCol==random[x]){
					alreadyExists=true;
					break;
				}
			}
		 	//check for block uniqueness
			if(alreadyExists==false){
				int blockRow=randomPositionX%3;   
				int blockColumn=randomPositionY%3;	
			alreadyExists=checkBlockSeries(blockRow, blockColumn, x, randomPositionX, randomPositionY);
			}
			
			if(alreadyExists==false){
				entry[randomPositionX][randomPositionY].setText(""+random[x]);
				entry[randomPositionX][randomPositionY].setBackground(Color.BLACK);
				entry[randomPositionX][randomPositionY].setEnabled(false);
				x++;
			}
		}
	}
	public static Boolean checkBlockSeries(int blockRow, int blockColumn, int x, int randomPositionX, int randomPositionY){
		Boolean isDup=false;
		for(int i=0;i<3;i++){
		int inLine1=0, inLine2=0, inLine3=0;
				
			if(entry[randomPositionX-blockRow][randomPositionY-blockColumn+i].getText().length()>0){
				inLine1=Integer.parseInt(entry[randomPositionX-blockRow][randomPositionY-blockColumn+i].getText());			
			}
			if(entry[randomPositionX-blockRow+1][randomPositionY-blockColumn+i].getText().length()>0){
				inLine2=Integer.parseInt(entry[randomPositionX-blockRow+1][randomPositionY-blockColumn+i].getText());
			}
			if(entry[randomPositionX-blockRow+2][randomPositionY-blockColumn+i].getText().length()>0){
				inLine3=Integer.parseInt(entry[randomPositionX-blockRow+2][randomPositionY-blockColumn+i].getText());
			}
			if(inLine1==random[x] || inLine2==random[x] || inLine3==random[x]){
				isDup=true;
				break;
				 }
			}
		return isDup;		
	}
}
class Result extends Game implements Runnable{
	static Boolean oneTime=true;	
	public void run(){
		while(true){
		Boolean areAllFilled=false, arePinkOrBlack=false, isRed=false;
		Label: for(int i=0;i<9;i++){
			for(int j=0;j<9;j++){
			Color color=entry[i][j].getBackground();
			if(color.BLACK.equals(color)||color.PINK.equals(color)){
				arePinkOrBlack=true;
			}
			else{
				arePinkOrBlack=false;
			}
			if(entry[i][j].getText().length()>0){
				areAllFilled=true;
			}
			else{
				areAllFilled=false;
				break Label;
				}	
			}	
		}	
		
			if(arePinkOrBlack && areAllFilled){
			
				JOptionPane.showMessageDialog(null,"<html><font size=5 color=Green>Congratulations!<br>You have Won the Game.");
				//We can add Sounds and Banners of congratulations here
				//Can ask again to play or exit
				//can provide option to share score and challenge others on facebook 
				System.exit(0);			
			}
		}
	}
}
class FieldListener extends Game implements KeyListener{
	
	JTextField field;
	static char key;
	static Boolean isValid=true;
	static int positionX=0, positionY=0;
	
	public void keyPressed(KeyEvent ke){
		
		key=ke.getKeyChar();	
		field=(JTextField)ke.getSource();
		if((int)key>48 && (int)key<=57){
			field.setBackground(Color.PINK);	
			isValid=true;
		}
		
		else{
			field.setBackground(Color.RED);
			isValid=false;
		}	
	}	
	
	public void keyTyped(KeyEvent ke){
		
		field=(JTextField)ke.getSource();
	}
	
	public void keyReleased(KeyEvent ke){
		if(field.getText().length()>1){
			JOptionPane.showMessageDialog(null,"Use Numbers 1-9");
			field.setText(field.getText().substring(0,1));
		}
		else{
		
		field=(JTextField)ke.getSource();
		if(isValid && field.getText().length()==1){
			for(int i=0;i<9;i++){
				for(int j=0;j<9;j++){
					if(field==entry[i][j]){
						positionX=i;		
						positionY=j;
						break;
					}	
				}
			}
			int val=Integer.parseInt(field.getText());	
			field.setText("");
			Boolean isDuplicate=validateThePosition(positionX, positionY, val);
			if(isDuplicate==false){
				field.setText(""+val);
			}	
			else{
				System.out.println("TRUE");	
				field.setText(""+val);
				field.setBackground(Color.RED);	
			}	
		}
		if(!isValid){
			field.setText("");
			field.setBackground(Color.CYAN);
			}	
		}
	}	
	public static Boolean validateThePosition(int positionX,int positionY, int insertedValue){
		
		Boolean isDuplicate=false;
		for(int i=0;i<9;i++){
			int inLine=0, inCol=0;
		
			if(entry[positionX][i].getText().length()>0){
				inLine=Integer.parseInt(entry[positionX][i].getText());			
			}
			if(entry[i][positionY].getText().length()>0){
				inCol=Integer.parseInt(entry[i][positionY].getText());
			}
			if(inLine==insertedValue || inCol==insertedValue){
				isDuplicate=true;
				break;
			}
		}
		//check for block uniqueness
		if(isDuplicate==false){
			int blockRow=positionX%3;   
			int blockColumn=positionY%3;	
		isDuplicate=validateBlockUniqueness(blockRow, blockColumn, insertedValue, positionX, positionY);
		}
		if(isDuplicate==false){
			entry[positionX][positionY].setText(""+insertedValue);
		}	
		return isDuplicate;
	}
	public static Boolean validateBlockUniqueness(int blockRow, int blockColumn, int insertedValue, int positionX, int positionY){
		Boolean isDup=false;
		for(int i=0;i<3;i++){
			
			int inLine1=0, inLine2=0, inLine3=0;
			if(entry[positionX-blockRow][positionY-blockColumn+i].getText().length()>0){
				inLine1=Integer.parseInt(entry[positionX-blockRow][positionY-blockColumn+i].getText());			
			}
			if(entry[positionX-blockRow+1][positionY-blockColumn+i].getText().length()>0){
				inLine2=Integer.parseInt(entry[positionX-blockRow+1][positionY-blockColumn+i].getText());
			}
			if(entry[positionX-blockRow+2][positionY-blockColumn+i].getText().length()>0){
				inLine3=Integer.parseInt(entry[positionX-blockRow+2][positionY-blockColumn+i].getText());
			}
			if(inLine1==insertedValue || inLine2==insertedValue || inLine3==insertedValue){
				isDup=true;
				break;
			}
		}
		return isDup;	
	}
}
class ButtonListener extends Game implements ActionListener{

	JButton b;
	static long muteTime=0l;
	static JButton unMute;
	public void actionPerformed(ActionEvent ae){
		b=(JButton)ae.getSource();
	
		if(b==mute){
			
			mute.setIcon(ic2);	
			muteTime=clip.getMicrosecondPosition();
			clip.close();
			unMute=mute;
			mute=null;
		}
		else if(b==unMute){
			unMute.setIcon(ic1);
			Thread th=new Thread(new BackgroundMusic());
			th.start();
			mute=unMute;
			unMute=null;
		}
		if(b==shuffle){
			x=0;
			Game.makeBoxesEmpty();
			Game.setRandoms();
		}
		if(b==solution){
					
		}
		if(b==exit){
			System.exit(0);
		}
	}
}
class BackgroundMusic extends ButtonListener implements Runnable{
	
	public void run(){
	
	try{
			ais=AudioSystem.getAudioInputStream(new File("NoOne.WAV").getAbsoluteFile());
			clip=AudioSystem.getClip();
			clip.open(ais);
			clip.setMicrosecondPosition(muteTime);
			clip.loop(Clip.LOOP_CONTINUOUSLY);
		}
		catch(Exception exceptions){}	
	}
}
class Timer extends ButtonListener implements Runnable{
	static int  storeM=minute, storeS=second;	
	
	public void run(){		
		for(int i=60;i>=0;i--){			
			second--;
			showTime.setText("<html><font color=aqua>Time </font><font color=red>"+minute+" : "+second);			try{Thread.sleep(1000);}catch(Exception ex){}
			if(second==0){
				minute--;
				second=60;
				i=60;
			}
			if(minute<0){
				JOptionPane.showMessageDialog(null,"Time over\nPlay Again?");			
				f.setVisible(false);	
				minute=storeM;
				second=storeS;
				muteTime=0l;
				clip.close();
				Test.startGame();
				break;
				}					
		}
	}
}